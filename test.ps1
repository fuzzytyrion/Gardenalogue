# Test
function Exec {
    [CmdletBinding()]
    param(
        [Parameter(Position=0,Mandatory=1)][scriptblock]$cmd,
        [Parameter(Position=1,Mandatory=0)][string]$errorMessage = ($msgs.error_bad_command -f $cmd)
    )
    & $cmd
    if ($lastexitcode -ne 0) {
        throw ("Exec: " + $errorMessage)
    }
}

echo "`n`n----- TEST -----`n"

exec { & dotnet tool install --global coverlet.console }

exec { & dotnet test src /p:CollectCoverage=true /p:CoverletOutputFormat=opencover /p:CoverletOutput=$root\coverage /p:MergeWith=$root\coverage.json /p:Include="[*]Gardenalogue.*" /p:Exclude="[*]Gardenalogue.Testing.*" $format }

choco install codecov --no-progress
exec { & codecov -f "$root\coverage.opencover.xml" }
