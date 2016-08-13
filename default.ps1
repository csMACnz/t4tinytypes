properties {
    $base_dir = . resolve-path .\
    $script:nuget_version = 0.0.1
}

# Probably will just build, decide later
task default

task gitversion {
    nuget install GitVersion.CommandLine -Version 3.6.0 -OutputDirectory BuildTools
    $gitversion = Resolve-Path "BuildTools/GitVersion.*/tools/gitversion.exe"
    $str = & $gitversion | out-string
    $json = ConvertFrom-Json $str

    #I might have to change this, but I basically want major.minor.patch.commitcount
    $script:nuget_version = "$($json.MajorMinorPatch).$($json.CommitsSinceVersionSource)"
    Write-Host "Version: $nuget_version"
}

task test -depends dotnettest, vstest

task dotnettest {
    nuget install Mono.TextTransform -Version 1.0.0 -OutputDirectory BuildTools
    # run first because bug: https://github.com/dotnet/cli/issues/3807
    cd $base_dir/test/dotnetcli/t4tinytypes.sample
    ./generateCode.cmd

    cd $base_dir/test/dotnetcli
    dotnet restore

    dotnet build t4tinytypes.sample

    dotnet test t4tinytypes.sample.tests
}

task vstest {
    #TODO
    msbuild $base_dir/test/visualstudio/t4tinytypes.sample.sln
}

task pack -depends gitversion {
    $package_dir = "$base_dir\pack"
    if (Test-Path $package_dir) {
        Remove-Item $package_dir -r
    }
    mkdir $package_dir

    cd $base_dir/src/t4tinytypes
    nuget pack -OutputDirectory $package_dir -Version $script:nuget_version -NonInteractive
}

task appveyor-install -depends gitversion

task appveyor-build #TODO

task appveyor-test -depends test, pack