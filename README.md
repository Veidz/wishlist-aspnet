# Wishlist - ASP.NET

## Getting Started

First, start mongo server instance with Docker:

```bash
docker run -e MONGO_INITDB_ROOT_USERNAME=root -e MONGO_INITDB_ROOT_PASSWORD=root -p 27016:27017 -d mongo
```

After that, go to the API folder:
```bash
cd Wishlist/Wishlist.API
```

Then, run the development server:
```bash
dotnet run
```

The server will be running at http://localhost:5127 where 5127 is the env port (launchSettings.json).
