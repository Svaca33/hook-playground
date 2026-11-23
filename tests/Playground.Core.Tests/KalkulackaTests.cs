using Playground.Core;

public class KalkulackaTests
{
    [Fact]
    public void Secti_dve_cisla() => Assert.Equal(4, Kalkulacka.Secti(2, 2));
}