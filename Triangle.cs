using System;
using System.Collections.Generic;

public class Triangle
{
  private int _sideA;
  private int _sideB;
  private int _sideC;

  public Triangle(int sideLengthA, int sideLengthB, int sideLengthC)
  {
    _sideA = sideLengthA;
    _sideB = sideLengthB;
    _sideC = sideLengthC;
  }

  public void SetSideA(int newSideA)
  {
    _sideA = newSideA;
  }
  public int GetSideA()
  {
    return _sideA;
  }

  public void SetSideB(int newSideB)
  {
    _sideB = newSideB;
  }
  public int GetSideB()
  {
    return _sideB;
  }

  public void SetSideC(int newSideC)
  {
    _sideC = newSideC;
  }
  public int GetSideC()
  {
    return _sideC;
  }

  public void isThisATriangle()
  {
    if (_sideA + _sideB < _sideC || _sideB + _sideC < _sideA || _sideA + _sideC < _sideB)
    {
      Console.WriteLine("This is not a triangle.");
    }
    else
    {
      if(_sideA == _sideB && _sideA == _sideC)
      {
        Console.WriteLine("This is an equilateral triangle.");
      }
      else if (_sideA == _sideB || _sideB == _sideC || _sideA == _sideC)
      {
        Console.WriteLine("This is an isosceles triangle.");
      }
      else
      {
        Console.WriteLine("This is a scalene triangle.");
      }
    }
  }
}

public class Program
{
  public static void Main()
  {
    Console.WriteLine("What is the first side's length?");
    int newSideA = int.Parse(Console.ReadLine());
    Console.WriteLine("What is the second side's length?");
    int newSideB = int.Parse(Console.ReadLine());
    Console.WriteLine("What is the third side's length?");
    int newSideC = int.Parse(Console.ReadLine());
    Triangle newTriangle = new Triangle(newSideA, newSideB, newSideC);
    newTriangle.isThisATriangle();
  }
}
