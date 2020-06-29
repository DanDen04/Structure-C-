# Exponentiation
1. Создание класса **DoubleInDeg**(Дробное в степень)
2. Создание приватных полей *First* и *Second* в классе **DoubleInDeg**
3. Создание конструктора(DoubleInDeg(first, second))
```csharp
        public DoubleInDeg(double first, int second)
        {
            this.First = first;
            this.Second = second;
        }
```
4. Создание метода **Power**. (double())
```csharp
        public double Power()
        {
            double result = 1.0;

            if (this.Second >= 0)
            {
                for (int i = 0; i < this.Second; i++)
                {
                    result *= this.First;
                }
            }
            else
            {
                for (int i = 0; i > this.Second; i--)
                {
                    result *= (1 / this.First);
                }
            }

            return result;
        }
```
5. Создание класса **UnitTestDoubleInDeg**.
6. Создание метода *TestDIG()* в классе **UnitTestDoubleInDeg**.
7. Создание объекта **doubleInDeg** и помещение в него значений.
```csharp
DoubleInDeg doubleInDeg1 = new DoubleInDeg(2, 3);
```
8. Проверка
```csharp
            if (doubleInDeg1.Power() != 8)
            {
                throw new Exception();
            }
```
9. Создание объекта **unitTestDoubleInDeg** в классе **Program** и обращение к методу *TestDIG()*.
```csharp
            UnitTestDoubleInDeg unitTestDoubleInDeg = new UnitTestDoubleInDeg();
            unitTestDoubleInDeg.TestDIG();
```
