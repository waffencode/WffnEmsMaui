using WffnEmsMaui.Domain;

namespace WffnEmsMaui.Test
{
    public class EmployeeTest
    {
        [Fact]
        public void IdShouldNotBeNull()
        {
            Employee employee = new();
            Assert.NotEqual(Guid.Empty, employee.Id);
        }

        [Fact]
        public void ShouldAcceptValidName()
        {
            Employee employee = new();
            var exception = Record.Exception(() => ChangeEmployeeName(employee, "Test"));
            Assert.Null(exception);
        }

        [Fact]
        public void ShouldThrowExceptionForInvalidName()
        {
            Employee employee = new();

            Exception? exception = Record.Exception(() => ChangeEmployeeName(employee, "test"));
            Assert.NotNull(exception);
            exception = Record.Exception(() => ChangeEmployeeName(employee, "tEsT"));
            Assert.NotNull(exception);
            exception = Record.Exception(() => ChangeEmployeeName(employee, "TesT"));
            Assert.NotNull(exception);
        }

        [Fact]
        public void ShouldReturnValidName()
        {
            Employee employee = new()
            {
                Name = "Test"
            };
            Assert.Equal("Test", employee.Name);
        }

        private static void ChangeEmployeeName(Employee employee, string name)
        {
            employee.Name = name;
        }

        private static void ChangeEmployeeSurname(Employee employee, string surname)
        {
            employee.Surname = surname;
        }
    }
}