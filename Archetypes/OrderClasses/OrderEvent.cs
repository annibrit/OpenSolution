using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.OrderClasses
{
    public class OrderEvent : Archetype
    {
        //orderIdentifier - The OrderIdentifier for the Order to which the OrderEvent applies 
        //authorization [0..*] - Zero or more PartySignatures authorizing the OrderEvent(business rules dictate what authorizations are required for a particular type of event
        //dateAuthorized - The TimeDate when all required authorizations have been obtained 
        //processed - An indicator to show that the OrderEvent has been fully processed 
    }
}