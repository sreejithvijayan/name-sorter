namespace NameSorter.Tests
{
    public class NameSorterServiceTest
    {
        [Fact]
        public void SortNames_ShouldSortByLastName()
        {
            // Arrange
            var names = new List<string> { "John Doe", "Jane Smith", "Alice Johnson" };
            var expected = new List<string> { "John Doe", "Alice Johnson", "Jane Smith" };

            // Act
            var result = NameSorterService.SortNames(names);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void SortNames_ShouldSortByFirstNameWhenLastNamesAreSame()
        {
            // Arrange
            var names = new List<string> { "John Doe", "Jane Doe", "Alice Doe" };
            var expected = new List<string> { "Alice Doe", "Jane Doe", "John Doe" };

            // Act
            var result = NameSorterService.SortNames(names);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void SortNames_ShouldHandleEmptyList()
        {
            // Arrange
            var names = new List<string>();
            var expected = new List<string>();

            // Act
            var result = NameSorterService.SortNames(names);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void SortNames_ShouldHandleSingleName()
        {
            // Arrange
            var names = new List<string> { "John Doe" };
            var expected = new List<string> { "John Doe" };

            // Act
            var result = NameSorterService.SortNames(names);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void SortNames_ShouldSortByLastName_LargeData()
        {
            // Arrange
            var names = new List<string>
        {
            "Janet Parsons",
"Vaughn Lewis",
"Adonis Julius Archer",
"Shelby Nathan Yoder",
"Marin Alvarez",
"London Lindsey",
"Beau Tristan Bentley",
"Leo Gardner",
"Hunter Uriah Mathew Clarke",
"Mikayla Lopez",
"Frankie Conner Ritter"
        };

            var expected = new List<string>
        {
           "Marin Alvarez",
"Adonis Julius Archer",
"Beau Tristan Bentley",
"Hunter Uriah Mathew Clarke",
"Leo Gardner",
"Vaughn Lewis",
"London Lindsey",
"Mikayla Lopez",
"Janet Parsons",
"Frankie Conner Ritter",
"Shelby Nathan Yoder"
        };


            // Act
            var result = NameSorterService.SortNames(names);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void SortNames_ShouldSortByLastName_LargeData_AnotherDataset()
        {
            // Arrange
            var names = new List<string>
        {
            "John Doe",
    "Alice Johnson",
    "Jane Smith",
    "Michael Brown",
    "Emily Davis",
    "Daniel Garcia",
    "Chris Taylor",
    "Sophia Wilson",
    "Matthew Miller",
    "Olivia Harris"
        };

            var expected = new List<string>
        {
           "Michael Brown",
    "Emily Davis",
    "John Doe",
    "Daniel Garcia",
    "Olivia Harris",
    "Alice Johnson",
    "Matthew Miller",
    "Jane Smith",
    "Chris Taylor",
    "Sophia Wilson"
        };


            // Act
            var result = NameSorterService.SortNames(names);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}