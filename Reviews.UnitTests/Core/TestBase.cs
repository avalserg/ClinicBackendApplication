using AutoFixture;
using Castle.Core.Internal;
using Reviews.UnitTests.Core.Helpers;
using Xunit.Abstractions;

namespace Reviews.UnitTests.Core;

public abstract class TestBase
{
    private readonly Lazy<IFixture> _lazyFixture;
    private readonly ITestOutputHelper _testOutput;
    //comment

    protected TestBase(ITestOutputHelper testOutputHelper)
    {
        _testOutput = testOutputHelper;
        _lazyFixture = new Lazy<IFixture>(CreateFixture);
    }

    protected IFixture TestFixture => _lazyFixture.Value;

    protected virtual IFixture CreateFixture() => FixtureHelper.DefaultFixture;

    protected void WriteOutput(string message, params object[] args)
    {
        if (args.IsNullOrEmpty())
        {
            _testOutput.WriteLine(message);
        }
        else
        {
            _testOutput.WriteLine(message, args);
        }
    }
}