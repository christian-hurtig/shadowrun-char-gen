using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shadowrun_char_gen {
    public class CharacterBase : INotifyPropertyChanged {
        public string name { get; set; }
        Race race;
        string[] priorities;
        List<Skill> skills;
        List<SkillGroup> skillgroups;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name {
            get {
                return name;
            }

            set {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public CharacterBase(Race race, string[] priorities) {
            Name = "Unknown";
            this.race = race;
            this.priorities = priorities;

            skills = new List<Skill>();
            skillgroups = new List<SkillGroup>();

            skillgroups.Add(new SkillGroup("Close Combat"));
            skills.Add(new Skill("Blades", race.Agility, 0, skillgroups.Find(x => x.name.Equals("Close Combat", StringComparison.Ordinal))));
            skills.Add(new Skill("Clubs", race.Agility, 0, skillgroups.Find(x => x.name.Equals("Close Combat", StringComparison.Ordinal))));
            skills.Add(new Skill("Unarmed Combat", race.Agility, 0, skillgroups.Find(x => x.name.Equals("Close Combat", StringComparison.Ordinal))));
        }

        protected void OnPropertyChanged(string property) {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) {
                handler(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}