rm *.nupkg
nuget pack .\Vector2Extensions.nuspec -IncludeReferencedProjects -Prop Configuration=Release
nuget pack .\Vector2Extensions.Bridge.nuspec -IncludeReferencedProjects -Prop Configuration=Release
cp *.nupkg C:\Projects\Nugets\
nuget push *.nupkg -Source https://www.nuget.org/api/v2/package