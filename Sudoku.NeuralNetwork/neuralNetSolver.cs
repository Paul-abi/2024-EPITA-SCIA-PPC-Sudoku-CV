﻿using Sudoku.Shared;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Python.Deployment;
using Python.Runtime;
namespace Sudoku.NeuralNetwork;

public class NeuralNetSolver : PythonSolverBase
{
    public override SudokuGrid Solve(SudokuGrid s)
    {
        using (PyModule scope = Py.CreateScope())
        {

            // Injectez le script de conversion
            AddNumpyConverterScript(scope);

            // Convertissez le tableau .NET en tableau NumPy
            var pyCells = AsNumpyArray(s.Cells, scope);

            // create a Python variable "instance"
            scope.Set("instance", pyCells);

            // run the Python script
            string code = 9millions.main.py;
            scope.Exec(code);

            PyObject result = scope.Get("result");

            // Convertissez le résultat NumPy en tableau .NET
            var managedResult = AsManagedArray(scope, result);
            
            Console.WriteLine(result);
            
            return new SudokuGrid() { Cells = managedResult };
        }

        return s;
    }
    
   
}