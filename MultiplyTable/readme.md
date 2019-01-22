# Multiply Table #

### Task ###

To build a console application that will produce multiplication tables.

The finished application should be of production quality, regarding design, testing, maintainability etc.

### Assessment ###

The task will be assessed based on the following criteria:

-   All requirements are fulfilled
-   The code is readable
-   The application is well designed
-   The application is tested. (Include all test cases in your submission.)

### Requirements ###

The application writes a multiplication table based on a given number of rows and columns.

The table can be written to the console, to a comma-separated file, or to a HTML file.

**Inputs**

-   The application is run from the console
-   The command line has the following format:

multiply.exe rows [cols] [output-format]

-   For example:
    multiply.exe 4 5 csv
    multiply.exe 10 html
-   Valid values for output-format are console, csv and html.
-   Valid values for rows and cols are integers between 1 and 20.

**Incomplete inputs**

-   If the user does not provide output-format, the results are output to the console.
-   If the user does not provide the number of columns, the table should have the same width and height (cols = rows).

**Incorrect inputs**

-   If the user provides incorrect inputs, a user-friendly error message should be shown together with a reminder of the correct way to run the application.

**Outputs**

-   The application writes a multiplication table to the appropriate target.
-   The multiplication table will have row and column headers, in addition to the data.
-   For CSV and HTML formats, the file can be created directly in the application folder.
-   The file name should be in the following format:
    multiply_rows_cols
-   For example:
    multiply_3_7.csv
    multiply_4_4.html
-   When output to the console, the table should have right-aligned columns. For example, a 3x4 table:
        1   2   3   4
    1   1   2   3   4
    2   2   4   6   8
    3   3   6   9  12
-   The HTML code does not need pretty formatting (indenting etc).
-   The output files must be valid. The comma-separated file should adhere to specifications and be importable into e.g. Excel. The HTML file must open and render correctly in Firefox.

### Delimitation ###

-   Execution speed is irrelevant, within reasonable limits. Readability is valued higher than performance.                    
