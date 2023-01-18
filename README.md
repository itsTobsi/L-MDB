# L-MDB
## Lite - Movie DataBase

- [ ] Decide what to use. [XAML](https://www.youtube.com/watch?v=EfXz4C5cSVI) or [WinForms](https://www.youtube.com/watch?v=I8ZYsYrdeL4) 
- [ ] Make a dummy database with data
  - [X] Variables made: ```movieTitle``` and ```releaseYear```
        SQL Query: 
```SQL
INSERT INTO dbo.tempDB (movieTitle, releaseYear)    -- Where to insert the data
VALUES ('Violent Night', '2022'),                   -- What to insert 
('The Godfather', '1972'),
('Pulp Fiction', '1994'),
('Fear and Loathing in Las Vegas', '1998'),
('Police Academy 2: Their First Assignment', '1985');

SELECT * FROM dbo.tempDB                            -- Shows the inserted data in the database
```  

### Res

[To programmaticly add elements to the form](https://www.c-sharpcorner.com/UploadFile/mahesh/tablelayoutpanel-in-C-Sharp/) 