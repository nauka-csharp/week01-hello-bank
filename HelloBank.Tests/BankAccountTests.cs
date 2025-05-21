using FluentAssertions;

namespace HelloBank.Tests;

public class BankAccountTests
{
    [Fact]
    public void Deposit_Increases_Balance_0()
    {
        // Arrange – przygotuj dane i obiekt
        var acc = new BankAccount("Jan", 100m);

        // Act – wykonaj jedną akcję
        Action act = () => acc.MakeDeposit(0m, DateTime.Now, "wpłata");

        // Assert – sprawdź wynik
        act.Should().Throw<ArgumentOutOfRangeException>();   // FluentAssertions
    }
    public void Deposit_Increases_Balance_Negative()
    {
        // Arrange – przygotuj dane i obiekt
        var acc = new BankAccount("Jan", 100m);

        // Act – wykonaj jedną akcję
        Action act = ()=>acc.MakeDeposit(-1000m, DateTime.Now, "wpłata");

        // Assert – sprawdź wynik
        act.Should().Throw<ArgumentOutOfRangeException>();   // FluentAssertions
    }
    [Fact]
    public void Withdraw_Decreases_Balance()
    {
        // Arrange
        var acc = new BankAccount("Jan", 100m);
        // Act
        acc.MakeWithdrawal(50m, DateTime.Now, "wypłata");
        // Assert
        acc.Balance.Should().Be(50m);
    }
    [Fact]
    public void Withdraw_Throws_InvalidOperationException_When_InsufficientFunds()
    {
        // Arrange
        var acc = new BankAccount("Jan", 100m);
        // Act
        Action act = () => acc.MakeWithdrawal(200m, DateTime.Now, "wypłata");
        // Assert
        act.Should().Throw<InvalidOperationException>();
    }

    [Fact]
    public void KindDeposit_Returns_DEPOSIT()
    {
        // Arrange
        var t = new Transaction(150m, DateTime.UtcNow, "Wplata");
        // Act
        var kind = t.Kind;
        // Assert
        kind.Should().Be("DEPOSIT");
    }
    [Fact]
    public void KindWithdrawal_Returns_WITHDRAWAL()
    {
        // Arrange
        var t = new Transaction(-150m, DateTime.UtcNow, "Wplata");
        // Act
        var kind = t.Kind;
        // Assert
        kind.Should().Be("WITHDRAWAL");
    }
}
