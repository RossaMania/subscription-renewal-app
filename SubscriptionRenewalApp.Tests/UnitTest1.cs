
public class SubscriptionRenewalService
{
    public string GetRenewalMessage(int daysUntilExpiration)
    {
        int discountPercentage = 0;
        if (daysUntilExpiration > 10)
        {
            return "";
        }
        else if (daysUntilExpiration == 1)
        {
            discountPercentage = 20;
            return $"Your subscription expires within a day! Renew now and save {discountPercentage}%!";
        }
        else if (daysUntilExpiration == 0)
        {
            return "Your subscription has expired.";
        }
        else if (daysUntilExpiration <= 5)
        {
            discountPercentage = 10;
            return $"Your subscription expires in {daysUntilExpiration} days. Renew now and save {discountPercentage}%!";
        }
        else if (daysUntilExpiration <= 10)
        {
            return "Your subscription will expire soon. Renew now!";
        }
        return "";
    }
}

// NUnit tests
[TestFixture]
public class SubscriptionRenewalServiceTests
{
    private SubscriptionRenewalService _service;

    [SetUp]
    public void SetUp()
    {
        _service = new SubscriptionRenewalService();
    }

    [TestCase(10, "Your subscription will expire soon. Renew now!")]
    [TestCase(5, "Your subscription expires in 5 days. Renew now and save 10%!")]
    [TestCase(1, "Your subscription expires within a day! Renew now and save 20%!")]
    [TestCase(0, "Your subscription has expired.")]
    [TestCase(15, "")]
    public void GetRenewalMessage_ReturnsExpectedMessage(int daysUntilExpiration, string expectedMessage)
    {
        string actualMessage = _service.GetRenewalMessage(daysUntilExpiration);
        Assert.AreEqual(expectedMessage, actualMessage);
    }
}