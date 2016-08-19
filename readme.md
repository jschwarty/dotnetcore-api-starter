# A minimal starter pack for a .Net Core api

Download the zip of this repository and create your own
project. Requires **Docker** or **.Net Core 1.0**.

## Local initialization (docker)

1. Run docker compose up

```
docker-compose up
```

2. Open browser

```
http://localhost:5000/info
```


## Local initialization (dotnet installed)

1. Restore the packages

```
dotnet restore
```

2. Run the app

```
dotnet run
```

3. Open browser

```
http://localhost:5000/info
```

## Visual Studio Code support

There is a `launch.json` file that contains settings for running with debugging. Note that
the `program` entry points to the compiled dll which will be named based on your parent directory
name. So when you grab this repository code and put it in your own dir, you need to update
this property.

```
{
    ...
    "configurations": [
        {
            ...
            "program": "${workspaceRoot}\\bin\\Debug\\netcoreapp1.0\\<YOUR_DIR_HERE>.dll",
            ...
        }
    ]
    ...
}
```