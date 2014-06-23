using Cards.Domain.Standard;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Cards.Test
{
    [TestClass]
    public class StandardDeckTests
    {
        [TestMethod]
        public void CorrectNumberOfCards()
        {
            var deck = new Deck();
            Assert.AreEqual(52, deck.Cards.Count);
        }

        [TestMethod]
        public void CorrectNumberOfCardsPerSuit()
        {
            var deck = new Deck();
            Assert.AreEqual(13, deck.Cards.Count(c => c.Suit == Suit.Club));
            Assert.AreEqual(13, deck.Cards.Count(c => c.Suit == Suit.Diamond));
            Assert.AreEqual(13, deck.Cards.Count(c => c.Suit == Suit.Heart));
            Assert.AreEqual(13, deck.Cards.Count(c => c.Suit == Suit.Spades));
        }

        [TestMethod]
        public void CantTakeMoreThan52Cards()
        {
            var deck = new Deck();
            var cards = deck.TakeCards(52);
            Assert.IsNull(deck.TakeCard());
        }

        [TestMethod]
        public void TakenCardDoesntAppearInDeck()
        {
            var deck = new Deck();
            var takenCard = (Card)deck.TakeCard();
            Assert.IsFalse(deck.Cards.Any(c => c.Suit == takenCard.Suit &&
                                          c.CardNumber == takenCard.CardNumber));
        }

        [TestMethod]
        public void ResetPutsCountBack()
        {
            var deck = new Deck();
            var card = deck.TakeCard();
            Assert.AreEqual(51, deck.Cards.Count);
            deck.Reset();
            Assert.AreEqual(52, deck.Cards.Count);
        }

        [TestMethod]
        public void ResetWorksFromZero()
        {
            var deck = new Deck();
            var cards = deck.TakeCards(52);
            Assert.AreEqual(0, deck.Cards.Count);
            deck.Reset();
            Assert.AreEqual(52, deck.Cards.Count);
        }
    }
}
