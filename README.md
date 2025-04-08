# TriangleTypeptor

TriangleTypeptor is a C# program that determines the type of a triangle based on the lengths of its three sides. It identifies whether the triangle is **equilateral**, **isosceles**, or **scalene**, while also handling invalid inputs gracefully.

---

## Problem Description

The program solves the following problem:

1. **Input**: The program takes three integers as input, representing the lengths of the sides of a triangle.
2. **Output**: It determines and outputs whether the triangle is:
   - **Equilateral**: All three sides are equal.
   - **Isosceles**: Two sides are equal.
   - **Scalene**: All three sides are different.
   - **Not a triangle**: The sides do not form a valid triangle (e.g., they violate the triangle inequality or contain invalid values like zero or negative numbers).

This program is designed to showcase problem-solving skills, structural considerations, and attention to testing, readability, and error handling.

---

## Features

- **Triangle Type Detection**: Determines the type of triangle based on the side lengths.
- **Error Handling**: Handles invalid inputs such as non-integer values, negative numbers, or zero-length sides.
- **Comprehensive Tests**: Includes a robust set of test cases to validate the program's correctness.
- **Command-Line Interface**: Can be run directly from the command line.

---

## Build Instructions

To build the program, follow these steps:

1. Ensure you have the [.NET SDK](https://dotnet.microsoft.com/download) installed (version 7.x or later).
2. Clone the repository:
   ```bash
   git clone <repository-url>
   cd TriangleTypeptor
   ```
3. Restore dependencies:
   ```bash
   dotnet restore
   ```
4. Build the project:
   ```bash
   dotnet build --configuration Release
   ```

---

## Run Instructions

To run the program, use the following steps:

1. Navigate to the project directory.
2. Run the program with three side lengths as arguments:
   ```bash
   dotnet run --project TriangleTypeptor --configuration Release -- 3 4 5
   ```
   Replace `3 4 5` with the side lengths of the triangle you want to analyze.

3. Example outputs:
   - Input: `3 3 3` → Output: `The type of triangle is: Equilateral`
   - Input: `3 3 4` → Output: `The type of triangle is: Isosceles`
   - Input: `3 4 5` → Output: `The type of triangle is: Scalene`
   - Input: `1 2 3` → Output: `Not a triangle`

---

## Testing Instructions

The program includes a comprehensive set of unit tests to ensure correctness and robustness. To run the tests:

1. Navigate to the project directory.
2. Run the following command:
   ```bash
   dotnet test
   ```
3. The test suite covers:
   - Valid triangles (equilateral, isosceles, scalene).
   - Invalid triangles (e.g., sides that violate the triangle inequality).
   - Edge cases (e.g., zero or negative side lengths, non-integer inputs).

---

## Adding to OS as a Command

To make the program accessible globally via the command line:

1. Publish the project to generate an executable:
   ```bash
   dotnet publish --configuration Release --output <output-folder>
   ```
2. Add the `<output-folder>` path to your system's `PATH` environment variable:
   - **Windows**:
     1. Open "Environment Variables" settings.
     2. Add the `<output-folder>` path to the `Path` variable under "System Variables."
   - **Linux/Mac**:
     ```bash
     export PATH=$PATH:<output-folder>
     ```
3. You can now run the program from anywhere using:
   ```bash
   TriangleTypeptor 3 4 5
   ```

---

## Notes

- This program is designed to be simple yet robust, with a focus on readability and maintainability.
- Feel free to extend the program to handle additional features or edge cases.
- This software is provided "as is," without warranty of any kind, express or implied.

---

## Example Usage

### Input:
```bash
TriangleTypeptor 3 4 5
```

### Output:
```
The type of triangle is: Scalene
```

---

## License

This project is licensed under the GNU v3 License. See the LICENSE file for details.