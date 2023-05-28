
## MarkDownStoraqe

Markdown storage is a small project of mine to experiment with .net MVC and EntityFramework.

The project itself is small and written in less then 2 days as it's only used to get a basic idea how .net mvc and EF works.

## File API

In the project we have the file controller which is used to read and save files.

#### EndPoints:
GetFile is used to get a specific file from an ID. 
```
https://localhost:44317/File/GetFile/{id}
```

Add file is used to add a new file to the Sqlite database, add Data in the body to set it's respective data.
```
https://localhost:44317/File/AddFile/
```

GetFiles is used to fetch all files from the database, would like to add some limit to it such as a paging system to reduce bandwidth consumption.
```
https://localhost:44317/File/GetFiles/
```