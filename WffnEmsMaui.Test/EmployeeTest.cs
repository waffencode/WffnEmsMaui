using WffnEmsMaui.Domain;

namespace WffnEmsMaui.Test
{
    public class EmployeeTest
    {
        [Fact]
        public void EmployeeNameStartsByCapital()
        {
            Employee employee = new();
            Assert.Throws<Exception>(() => employee.Name = "name");
        }
    }
}