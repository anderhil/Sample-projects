Sample projects have two projects inside:

1. [Minumun Triangle Path](#minimum-triangle-path)
2. [Multiply Table](#multiply-table)

# Minimum Triangle Path #

## Background ##

Consider the following triangle of non-negative integers:

![uKkzGgl[1].png](https://bitbucket.org/repo/G8RjXd/images/1413163728-uKkzGgl%5B1%5D.png)

A path through the triangle is a sequence of adjacent nodes, one from each row, starting from the top. So, for instance, 7 6 3 11 is a path down the left hand edge of the triangle.

A minimal path is one where the sum of the values in its nodes is no greater than for any other path through the triangle. In this case, 7 + 6 + 3 + 2 = 18 is a minimal path.

We can store the triangle in a text file with each row on a separate line, and spaces between the numbers. Thus the triangle above would be stored in text format as:

7

6 3

3 8 5

11 2 10 9

**Task**

Write a command-line program that reads a text-format triangle from standard inputand outputs a minimal path to standard output as follows (using a file containing the triangle above):

> MinTrianglePath.exe testfile.txt
    Minimal path is: 7 + 6 + 3 + 2 = 18

An average PC should be able to produce the answer for a 

500-line triangle within 0.5 seconds. Be aware that your code will be reviewed by a human and so your source files should be clear, easy to follow and maintainable, as well as your solution generating correct answers within the time bound.

We will be looking for the ability to handle edge and error cases – such as being able to tell the end user whether and exactly where in the input there is an error (eg. line too short or too long or invalid value).

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
