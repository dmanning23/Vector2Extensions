nuget pack .\Vector2Extensions.nuspec -IncludeReferencedProjects -Prop Configuration=Release
nuget push *.nupkg