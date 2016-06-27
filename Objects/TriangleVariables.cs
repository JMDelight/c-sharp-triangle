namespace Triangle.Objects
{
  public class TriangleVariables
  {
    public int Side1 {get; set;}
    public int Side2 {get; set;}
    public int Side3 {get; set;}
    
    public bool TriangleChecker()
    {
      if (Side1 + Side2 <= Side3 || Side1 + Side3 <= Side2 || Side2 + Side3 <= Side1)
      {
        return false;
      }
      else
      {
        return true;
      }
    }

    public bool ScaleneChecker()
    {
      if (Side1 != Side2 && Side1 != Side3 && Side2 != Side3)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public bool EquilateralChecker()
    {
      if (Side1 == Side2 && Side1 == Side3)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public bool IsoscelesChecker()
    {
      if (Side1 == Side2 || Side1 == Side3 || Side2 == Side3)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public string TriangleTypeChecker()
    {
      if (!TriangleChecker())
      {
        return "not a triangle";
      }
      else if (ScaleneChecker())
      {
        return "scalene triangle";
      }
      else if (EquilateralChecker())
      {
        return "equilateral triangle";
      }
      else if (IsoscelesChecker())
      {
        return "isosceles triangle";
      }
      else
      {
        return "something went wrong, please contact the administrators.";
      }
    }
  }
}
