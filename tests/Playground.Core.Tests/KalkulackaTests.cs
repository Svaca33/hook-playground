using Playground.Core;

public class KalkulackaTests
{
    [Fact]
    public void Secti_dve_cisla() => Assert.Equal(5, Kalkulacka.Secti(2, 3));

    [Fact]
    public void Vynasob_dve_cisla() => Assert.Equal(6, Kalkulacka.Vynasob(2, 3));
}