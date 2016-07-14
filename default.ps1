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
    $script:nuget_version = $json.NuGetVersionV2
    Write-Host "Version: $nuget_version"
}

task test {
#TODO
}

task pack -depends gitversion {
    $package_dir = "$base_dir\pack"
    if (Test-Path $package_dir) {
        Remove-Item $package_dir -r
    }
    mkdir $package_dir

    cd src/t4tinytypes
    nuget pack -OutputDirectory $package_dir -Version $script:nuget_version -NonInteractive
}

