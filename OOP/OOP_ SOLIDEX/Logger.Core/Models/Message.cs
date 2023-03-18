
using Logger.Core.Enums;
using Logger.Core.Exeptions;
using Logger.Core.Models.Interfaces;
using Logger.Core.Units;

namespace Logger.Core.Models
{
    public class Message : IMessage
    {
        private string text;
        private string createdTime;

        public Message(string createdTime, string text, ReportLevel reportLevel)
        {
            this.CreatedTime = createdTime;
            this.Text = text;
            this.ReportLevel = reportLevel;
        }

        public string CreatedTime 
        {
            get => createdTime;

            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new EmptyCreatedTimeExeption();
                }

                if (!DateTimeValidator.ValidateDateTime(value))
                {
                    throw new InvalidDateTimeExeption();
                }

                createdTime = value;
            }
        }

        public string Text 
        { 
            get => text;
         
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new EmptyMassageTextExeption();
                }

                text = value;
            }
        }

        public ReportLevel ReportLevel { get; private set; }
    }
}
