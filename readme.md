# tmpps.infrastructure.template

## command

#### build

`dotnet build Tmpps.Infrastructure.Template.Tests/`

#### test

`dotnet test Tmpps.Infrastructure.Template.Tests/`

#### register nuget

```bash
dotnet build -c Release Tmpps.Infrastructure.Template
# replace version,api-key
dotnet pack -c Release --include-source -p:PackageVersion=${version} Tmpps.Infrastructure.Template
dotnet nuget push ./Tmpps.Infrastructure.Template/bin/Release/Tmpps.Infrastructure.Template.${version}.nupkg -k ${api-key} -s https://api.nuget.org/v3/index.json
```

## use circleCI CLI

#### validation config

`circleci config validate`

#### test

`circleci local execute --job test`

#### release

```bash
git tag X.Y.Z
git push origin --tags
```
