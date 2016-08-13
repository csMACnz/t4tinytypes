REM Run TextTransform
..\..\..\BuildTools\Mono.TextTransform.1.0.0\tools\TextTransform.exe template.tt -a NamespaceHint!t4tinytypes.sample
REM wait to make sure dotnet picks up the new files
REM sleep 0.5
REM Actually its this: https://github.com/dotnet/cli/issues/3807