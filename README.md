# EF Core Sqlite Test - Persistent Chart Data 
Testing Entity Framework Core implementation for Tensile Testing Machine Version 2.0

The TTM generates a chart with the axis: Load (Newtons) x Deformation (%). Each axis has its values saved in a list.

There are two tables, GRAFICO (Chart ID) and DADOS (Chart Data). The chart ID table contains the general information of the test, such as material used, date/time of the test and the Chart id. The Chart data table contains the values of the data, saved in the lists, and the respective chart id for each row. An example of the table GRAFICO below:

| GraficoID | Material | Registro |
|:--------:|:--------:|:--------:|
| 1 | Steel | 15/03/2022 21:24:48 |
| 2 | Aluminium | 18/03/2022 16:27:36 |
| 3 | Titanium | 02/04/2022 20:34:54 |

# Notes

This branch will no longer be the main branch soon. Code will be changed to English, and migrations will be deleted.

# Next Steps

- [] Change Chart id type from int to Guid
- [] Create all basic CRUD operations
- [] Test model construction with Records, instead of Classes
