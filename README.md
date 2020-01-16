# MovieDbCRUDApp

An MVC CRUD application made using ASP.Net and a connection to an SQL database. This app allows users to add, edit or delete movie records from a locally stored database.

The reason why I made this project was that I was set a challenge to create a CRUD application, I also wanted to improve my abilities as a front end developer and I believe creating this application has helped me do so by testing my HTML and CSS knowledge, this was done when i had to figure out the styling of every page and make sure that it was aesthetically pleasing.

 Technologies used:

    - C#,HTML,CSS
    - ASP.NET
    - Entity Framework
    - SQL server
    - Bootstrap
    - Git hub

Issues encountered:

    - Initial setup of git hub/git bash on a new laptop hindered committing changes
    - Homepage carousel images are at different sizes and look displeasing when stretched to look bigger

To run the code it should run if you press start in visual studio


Database structure(3 tables, 1 foreign key):

```sql
CREATE TABLE Genres(

GenreId INT NOT NULL IDENTITY PRIMARY KEY,
GenreName VARCHAR(50) NOT NULL,
)

CREATE TABLE Films(

FilmId INT NOT NULL IDENTITY PRIMARY KEY,
FilmName NVARCHAR(50) NOT NULL,
Duration INT NULL,
DirectorName VARCHAR(50),
Rating INT NOT NULL,
AgeRating NVARCHAR(20) NULL,
GenreId INT NOT NULL,
FOREIGN KEY (GenreId) REFERENCES Genres (GenreId)

)

CREATE TABLE Series(

SeriesId INT NOT NULL IDENTITY PRIMARY KEY,
SeriesName NVARCHAR(50),
NumberOfSeasons INT NOT NUll,
Rating INT NOT NULL,
AgeRating NVARCHAR(20) NULL,
GenreId INT NOT NULL,
FOREIGN KEY (GenreId) REFERENCES Genres (GenreId)

)

```
Homepage:



<img width="621" alt="Homepage" src="https://user-images.githubusercontent.com/57000810/72523187-2d354f00-3857-11ea-8203-1dc9b4fec3d7.PNG">




Films view:



<img width="699" alt="filmPage" src="https://user-images.githubusercontent.com/57000810/72523349-7f767000-3857-11ea-960a-35f2ec77580b.PNG">


Series view:


<img width="562" alt="series" src="https://user-images.githubusercontent.com/57000810/72523474-c7959280-3857-11ea-8441-a6ec7ffe8197.PNG">



