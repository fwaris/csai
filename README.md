# CSAI Website 

Fable, Elmish, React

# Build for production
(replace fake.sh with fake.cmd on windows)

Run: `./fake.sh build` 

All the files needed for deployment are under the `deploy` folder.

# Watch mode

Run: `./fake.sh build -t Watch`

# Running Fable without FAKE

- Install NPM dependencies: `yarn`
- Install Nuget dependencies: `dotnet restore build.proj`
- Building for development: `dotnet fable webpack-dev-server`
- Building for production: `dotnet fable webpack-cli`

# Deploy
webpages.eng.wayne.edu (ftp)
copy contents of 'deploy' to /opt/htdocs/ai


