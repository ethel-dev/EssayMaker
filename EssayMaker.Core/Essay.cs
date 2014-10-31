using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace EssayMaker.Core
{
    [DataContract]
    public class Essay:PropertyChangedBase
    {
        private string _author;
        private string _teacherName;
        private DateTime _date;
        private string _title;
        private string _thesis;
        private string _conclusion;

        public Essay()
        {
            Topics = new ObservableCollection<EssayTopic>();
        }

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
        public string Author
        {
            get { return _author; }
            set
            {
                _author = value;
                NotifyPropertyChange();
            }
        }

        [DataMember]
        public string TeacherName
        {
            get { return _teacherName; }
            set
            {
                _teacherName = value;
                NotifyPropertyChange();
            }
        }

        [DataMember]
        public DateTime Date
        {
            get { return _date; }
            set
            {
                _date = value;
                NotifyPropertyChange();
            }
        }

        [DataMember]
        public string Thesis
        {
            get { return _thesis; }
            set
            {
                _thesis = value;
                NotifyPropertyChange();
            }
        }

        [DataMember]
        public string Conclusion
        {
            get { return _conclusion; }
            set
            {
                _conclusion = value;
                NotifyPropertyChange(() => Conclusion);
            }
        }

        [DataMember]
        public ObservableCollection<EssayTopic> Topics { get; private set; }

        public static Essay CreateNew()
        {
            return new Essay()
            {
                Date = DateTime.Today,
                Topics =
                {
                    new EssayTopic() {Title = "Topic1"},
                    new EssayTopic() {Title = "Topic2"},
                    new EssayTopic() {Title = "Topic3"}
                }
            };
        }

        public string Serialize()
        {
            var serializer = new DataContractSerializer(typeof(Essay));
            string serializedData;
            using (var stream = new MemoryStream())
            {
                serializer.WriteObject(stream, this);
                stream.Position = 0L;
                serializedData = Encoding.UTF8.GetString(stream.ToArray(), 0, (int)stream.Length);
            }
            return serializedData;
        }

        public static Essay Deserialize(string serializedData)
        {
            //invalid data
            if (string.IsNullOrEmpty(serializedData))
                return null;

            var serializer = new DataContractSerializer(typeof(Essay));

            byte[] serializedByteArray = Encoding.UTF8.GetBytes(serializedData);

            Essay returnObject;

            using (var stream = new MemoryStream(serializedByteArray))
            {
                object obj = serializer.ReadObject(stream);
                returnObject = obj is Essay ? (Essay)obj : null;
            }
            return returnObject;
        }
    }
}

