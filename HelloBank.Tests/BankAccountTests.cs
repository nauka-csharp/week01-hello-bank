using FluentAssertions;

namespace HelloBank.Tests;

public class BankAccountTests
{
    [Fact]
    public void Deposit_Increases_Balance()
    {
        // Arrange – przygotuj dane i obiekt
        var acc = new BankAccount("Jan", 0m);

        // Act – wykonaj jedną akcję
        acc.MakeDeposit(100m, DateTime.Now, "wpłata");

        // Assert – sprawdź wynik
        acc.Balance.Should().Be(100m);   // FluentAssertions
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
}
