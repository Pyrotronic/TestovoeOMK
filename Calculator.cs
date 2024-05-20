
namespace TestovoeZavod
{ 
    public class Calculator
    {
        private readonly ICalculatorLogger _Logger;
        public Calculator(ICalculatorLogger logger)
        {
            _Logger = logger;
        }

        public double GetArea<T>(T obj) where T : ICalc
        {
            try
            {
                double area = obj.GetArea();
                _Logger.Log($"Площадь: {area}");
                return area;
            }
            catch (Exception ex)
            {
                _Logger.Log($"Ошибка расчётов: {ex.Message}");
                throw;
            }
            
        }

        public double GetPerimetr<T>(T obj) where T: ICalc
        {
            try
            {
                double perimetr = obj.GetPerimetr();
                _Logger.Log($"Периметр: {perimetr}");
                return perimetr;
            }
            catch(Exception ex)
            {
                _Logger.Log($"Ошибка расчётов: {ex.Message}");
                throw;
            }
        }
        
    }
}
