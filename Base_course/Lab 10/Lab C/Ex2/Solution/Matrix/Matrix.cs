using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace MatrixOperators
{
    public class Matrix
    {
        int[,] data;

        /// <summary>
        /// The constructor for the class.
        /// </summary>
        /// <param name="Size">Specifies the size of the matrix. The matrix is square so only one dimension is needed.</param>
        public Matrix(int size)
        {
            data = new int[size, size];
        }

        /// <summary>
        /// Enables access to individual values in the matrix.
        /// </summary>
        /// <param name="RowIndex">In combination with the ColumnIndex parameter specifies which value to get or set.</param>
        /// <param name="ColumnIndex">In combination with the RowIndex parameter specifies which value to get or set.</param>
        /// <returns></returns>
        public int this[int RowIndex, int ColumnIndex]
        {
            get
            {
                return data[RowIndex, ColumnIndex];
            }
            set
            {
                data[RowIndex, ColumnIndex] = value;
            }
        }

        /// <summary>
        /// Enables two matrices to be added together.
        /// </summary>
        /// <param name="Matrix1">The first matrix.</param>
        /// <param name="Matrix2">The second matrix.</param>
        /// <returns>The result of adding the two matrices.</returns>
        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            // The Matrix class only supports square matrices.
            // Matrices must be the same size for Matrix addition.
            if (matrix1.data.GetLength(0) == matrix2.data.GetLength(0))
            {
                Matrix newMatrix = new Matrix(matrix1.data.GetLength(0));

                // Iterate over every row in the matrix.
                for (int x = 0; x < matrix1.data.GetLength(0); x++)
                {
                    // Iterate over every column in the matrix.
                    for (int y = 0; y < matrix1.data.GetLength(1); y++)
                    {
                        newMatrix.data[x, y] = matrix1.data[x, y] + matrix2.data[x, y];
                    }
                }
                return newMatrix;
            }
            else
            {
                throw new MatrixNotCompatibleException(matrix1, matrix2, "Matrices not the same size.");
            }
        }

        /// <summary>
        /// Enables one matrix to be subtracted from another.
        /// </summary>
        /// <param name="Matrix1">The first matrix.</param>
        /// <param name="Matrix2">The second matrix.</param>
        /// <returns>The result of subtracting the second matrix from the first.</returns>
        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            // The Matrix class only supports square matrices.
            // Matrices must be the same size for Matrix subtraction.
            if (matrix1.data.GetLength(0) == matrix2.data.GetLength(0))
            {
                Matrix newMatrix = new Matrix(matrix1.data.GetLength(0));

                // Iterate over every row in the matrix.
                for (int x = 0; x < matrix1.data.GetLength(0); x++)
                {
                    // Iterate over every column in the matrix.
                    for (int y = 0; y < matrix1.data.GetLength(1); y++)
                    {
                        newMatrix.data[x, y] = matrix1.data[x, y] - matrix2.data[x, y];
                    }
                }
                return newMatrix;
            }
            else
            {
                throw new MatrixNotCompatibleException(matrix1, matrix2, "Matrices not the same size.");
            }
        }

        /// <summary>
        /// Enables two matrices to be multiplied together.
        /// </summary>
        /// <param name="Matrix1">The first matrix.</param>
        /// <param name="Matrix2">The second matrix.</param>
        /// <returns>The result of multiplying the two matices.</returns>
        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            // The Matrix class only supports square matrices.
            // Matrices must be the same size for Matrix multiplication.
            if (matrix1.data.GetLength(0) == matrix2.data.GetLength(0))
            {
                Matrix newMatrix = new Matrix(matrix1.data.GetLength(0));

                // Iterate over every row in the matrix.
                for (int x = 0; x < matrix1.data.GetLength(0); x++)
                {
                    // Iterate over every column in the matrix.
                    for (int y = 0; y < matrix1.data.GetLength(1); y++)
                    {
                        int temp = 0;
                        for (int z = 0; z < matrix1.data.GetLength(0); z++)
                        {
                            temp += matrix1.data[x, z] * matrix2.data[z, y];
                        }
                        newMatrix.data[x, y] = temp;
                    }
                }
                return newMatrix;
            }
            else
            {
                throw new MatrixNotCompatibleException(matrix1, matrix2, "Matrices not the same size.");
            }
        }

        /// <summary>
        /// Converts the Matrix object to a string object with formatting and line breaks.
        /// </summary>
        /// <returns>A formatted string representing the Matrix.</returns>
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            // Iterate over every row in the matrix.
            for (int x = 0; x < data.GetLength(0); x++)
            {
                // Iterate over every column in the matrix.
                for (int y = 0; y < data.GetLength(1); y++)
                {
                    builder.AppendFormat("{0}\t", data[x, y]);
                }
                builder.Append(Environment.NewLine);
            }

            return builder.ToString();
        }
    }

    /// <summary>
    /// A simple exception class for use in Matrix operator methods when incompatibel matrices are specified.
    /// </summary>
    public class MatrixNotCompatibleException : Exception
    {
        Matrix firstMatrix = null;
        Matrix secondMatrix = null;

        public Matrix FirstMatrix
        {
            get
            {
                return firstMatrix;
            }
        }

        public Matrix SecondMatrix
        {
            get
            {
                return firstMatrix;
            }
        }

        public MatrixNotCompatibleException()
            : base()
        {
        }

        public MatrixNotCompatibleException(string message)
            : base(message)
        {
        }

        public MatrixNotCompatibleException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public MatrixNotCompatibleException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public MatrixNotCompatibleException(Matrix matrix1, Matrix matrix2, string message)
            : base(message)
        {
            firstMatrix = matrix1;
            secondMatrix = matrix2;
        }
    }
}
