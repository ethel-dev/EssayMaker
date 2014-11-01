using System.Runtime.Serialization;
namespace EssayMaker.Core
{
    [DataContract]
    public class EssayTopic : PropertyChangedBase
    {
        private string _sentence;
        private string _examples;
        private string _concludingSentence;
        private string _title;

        [DataMember]
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                NotifyPropertyChange();
            }
        }

        [DataMember]
        public string Sentence
        {
            get { return _sentence; }
            set
            {
                _sentence = value;
                NotifyPropertyChange();
            }
        }

        [DataMember]
        public string Examples
        {
            get { return _examples; }
            set
            {
                _examples = value;
                NotifyPropertyChange();
            }
        }

        [DataMember]
        public string ConcludingSentence
        {
            get { return _concludingSentence; }
            set
            {
                _concludingSentence = value;
                NotifyPropertyChange();
            }
        }
    }
}