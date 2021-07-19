using UnityEngine;

public class GraphFunctionLibrary : MonoBehaviour
{
    #region --Custom Methods--
    
    /// <summary>
    /// Returns the appropriate method based on the provided GraphType.
    /// </summary>
    public static GraphFunction GetGraphFunction(GraphType _graphType)
    {
        switch (_graphType)
        {
            case GraphType.HorizontalLine:
                return HorizontalLine;
                
            case GraphType.SlopedLine:
                return SlopedLine;

            case GraphType.Squared:
                return Squared;

            case GraphType.Cubed:
                return Cubed;

            case GraphType.SquareRoot:
                return SquareRoot;

            case GraphType.Sine:
                return Sine;

            case GraphType.Cosine:
                return Cosine;
        }

        return null;
    }
    
    /// <summary>
    /// Simulates the graph of the sine function.
    /// </summary>
    private static Vector3 Sine(float _xInput, bool _positiveExponent, float _coefficient = 1f, float _yIntercept = 0f)
    {
        return new Vector3(_xInput, _coefficient * Mathf.Sin(_positiveExponent ? _xInput : -_xInput) + _yIntercept, 0);
    }
    
    /// <summary>
    /// Simulates the graph of the cosine function.
    /// </summary>
    private static Vector3 Cosine(float _xInput, bool _positiveExponent, float _coefficient = 1f, float _yIntercept = 0f)
    {
        return new Vector3(_xInput, _coefficient * Mathf.Cos(_positiveExponent ? _xInput : -_xInput) + _yIntercept, 0);
    }

    private static Vector3 HorizontalLine(float _xInput, bool _positiveExponent, float _coefficient = 1f, float _yIntercept = 0f)
    {
        float _yInput = _coefficient + _yIntercept;
        return new Vector3(_xInput, _yInput, 0);
    }
    
    /// <summary>
    /// Simulates the graph of a line.
    /// </summary>
    private static Vector3 SlopedLine(float _xInput, bool _positiveExponent, float _coefficient = 1f, float _yIntercept = 0f)
    {
        float _yInput = _coefficient * (_positiveExponent ? _xInput : -_xInput) + _yIntercept;
        return new Vector3(_xInput, _yInput, 0);
    }

    /// <summary>
    /// Simulates the graph of a parabola.
    /// </summary>
    private static Vector3 Squared(float _xInput, bool _positiveExponent, float _coefficient = 1f, float _yIntercept = 0f)
    {
        return Parametric(_xInput, _positiveExponent, 2, _coefficient, _yIntercept);
    }

    /// <summary>
    /// Simulates the graph of a trivalent (cubic function).
    /// </summary>
    private static Vector3 Cubed(float _xInput, bool _positiveExponent, float _coefficient = 1f, float _yIntercept = 0f)
    {
        return Parametric(_xInput, _positiveExponent, 3, _coefficient, _yIntercept);
    }
    
    /// <summary>
    /// Simulates the graph of a square root function.
    /// </summary>
    private static Vector3 SquareRoot(float _xInput, bool _positiveExponent, float _coefficient = 1f, float _yIntercept = 0f)
    {
        float _yInput = _coefficient * Mathf.Pow(_xInput, _positiveExponent ? .5f : -.5f) + _yIntercept;
        return new Vector3(_xInput, _yInput, 0);
    }

    /// <summary>
    /// Helper method for parametric functions.
    /// </summary>
    private static Vector3 Parametric(float _xInput, bool _positiveExponent, float _power, float _coefficient = 1f, float _yIntercept = 0f)
    {
        float _yInput = _coefficient * Mathf.Pow(_xInput, _positiveExponent ? _power : -_power) + _yIntercept;
        return new Vector3(_xInput, _yInput, 0);
    }
    
    #endregion
    
}
