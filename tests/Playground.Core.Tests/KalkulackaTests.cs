using Playground.Core;

public class KalkulackaTests
{
    [Theory]
    [InlineData(2, 3, 5)]
    [InlineData(-2, 5, 3)]
    [InlineData(0, 7, 7)]
    [InlineData(int.MaxValue, 0, int.MaxValue)]
    [InlineData(int.MinValue, 0, int.MinValue)]
    public void Secti_vraci_soucet(int a, int b, int ocekavany) =>
        Assert.Equal(ocekavany, Kalkulacka.Secti(a, b));

    [Theory]
    [InlineData(int.MaxValue, 1)]
    [InlineData(int.MinValue, -1)]
    public void Secti_pri_preteceni_vyhodi_vyjimku(int a, int b) =>
        Assert.Throws<OverflowException>(() => Kalkulacka.Secti(a, b));

    [Fact]
    public void Vynasob_dve_cisla() => Assert.Equal(6, Kalkulacka.Vynasob(2, 3));
}
