namespace DiamondKata.UnitTests
{
    public class DiamondTests
    {
        [Test]
        public void A_should_return_single_line_A()
        {
            string expected = "A\n";

            Assert.That(Diamond.Create('A'), Is.EqualTo(expected));
        }

        [Test]
        public void B_should_return_diamond()
        {
            string expected = " A \n" +
                              "B B\n" +
                              " A \n";

            Assert.That(Diamond.Create('B'), Is.EqualTo(expected));
        }

        [Test]
        public void C_should_return_diamond()
        {
            string expected = "  A  \n" +
                              " B B \n" +
                              "C   C\n" +
                              " B B \n" +
                              "  A  \n";

            Assert.That(Diamond.Create('C'), Is.EqualTo(expected));
        }

        [Test]
        public void D_should_return_diamond()
        {
            string expected = "   A   \n" +
                              "  B B  \n" +
                              " C   C \n" +
                              "D     D\n" +
                              " C   C \n" +
                              "  B B  \n" +
                              "   A   \n";

            Assert.That(Diamond.Create('D'), Is.EqualTo(expected));
        }

        [Test]
        public void E_should_return_diamond()
        {
            string expected = "    A    \n" +
                              "   B B   \n" +
                              "  C   C  \n" +
                              " D     D \n" +
                              "E       E\n" +
                              " D     D \n" +
                              "  C   C  \n" +
                              "   B B   \n" +
                              "    A    \n";

            Assert.That(Diamond.Create('E'), Is.EqualTo(expected));
        }

        [Test]
        public void UTF_lower_than_A_should_return_empty_string()
        {
            Assert.That(Diamond.Create('!'), Is.EqualTo(""));
        }

        [Test]
        public void UTF_greater_than_A_should_return_empty_string()
        {
            Assert.That(Diamond.Create(']'), Is.EqualTo(""));
        }

        [Test]
        public void lowercase_a_should_return_single_line_A()
        {
            string expected = "A\n";

            Assert.That(Diamond.Create('a'), Is.EqualTo(expected));
        }

        [Test]
        public void lowercase_b_should_return_uppercase_diamond()
        {
            string expected = " A \n" +
                              "B B\n" +
                              " A \n";

            Assert.That(Diamond.Create('b'), Is.EqualTo(expected));
        }
    }
}