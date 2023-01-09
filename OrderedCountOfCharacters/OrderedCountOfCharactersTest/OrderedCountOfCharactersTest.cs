using OrderedCountOfCharacters;
namespace OrderedCountOfCharactersTest;

    [TestFixture]
    public class ExampleTestSuite {
        [Test]
        public void ExampleTests1()
        {
            Assert.That(
                Kata.OrderedCount("abracadabra"), 
                Is.EqualTo(new List<Tuple<char, int>>() {
                    tuple('a', 5),
                    tuple('b', 2),
                    tuple('r', 2),
                    tuple('c', 1),
                    tuple('d', 1)
                }));
        }
        [Test]
        public void ExampleTests3()
        {
            Assert.That(
                Kata.OrderedCount(" Ccode Wars "), 
                Is.EqualTo(new List<Tuple<char, int>> () {  
                    tuple(' ', 3),
                    tuple('C', 1),
                    tuple('c', 1),
                    tuple('o', 1),
                    tuple('d', 1),
                    tuple('e', 1),
                    tuple('W', 1),
                    tuple('a', 1),
                    tuple('r', 1),
                    tuple('s', 1)
                }));
        }
        
        private static Tuple<char, int> tuple(char character, int count) {
            return new Tuple<char, int>(character, count);
        }
    }
