namespace Music.Helpers.Controls;

public enum EntryValidatorType
{
    None,
    Required,
    Email,
    Password,
    Word,  // not allow spaces  "Boss"
    Phrase, //Allow Spaces Example "The Boss"
    GameName,
    Comment,
    AskQuestions,
    AnswerQuestions,
    DisplayName,
    Message,
    Feedback,
    PersonName,
    Number,
    URL,
    Zip,
    CellPhone,
    City,
    Question,
    PhoneOne,
    PhoneTwo,
    PhoneThree

}