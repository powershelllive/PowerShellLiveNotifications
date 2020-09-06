[CmdletBinding()]
param (
    [Parameter(Mandatory=$false)]
    [string]
    $BasePath = $PWD
)

$global:PromptProjectBasePath = $BasePath
$Function:prompt = {
        $path = $pwd -replace [regex]::Escape($global:PromptProjectBasePath)
        $matchString = '^{0}' -f [regex]::Escape(
            [System.IO.Path]::DirectorySeparatorChar
        )
        if($path -notmatch $matchString) {
            $path = "{0}{1}" -f
                [System.IO.Path]::DirectorySeparatorChar, $path
        }
        return "PS $path> "
}
