using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaveAnalyzer.Models;

namespace WaveAnalyzer.Tools
{
    public class NoteTools
    {
        public string configDirectory;
        private String basicNotesFile;
        private String majorScaleSeqFile; 
        private String minorScaleSeqFile;
        private String majorChordsFile;
        private String minorChordsFile;
        public Dictionary<int, string> basicNotesSequence;
        public List<int> majorScaleSeq, minorScaleSeq;

        public readonly int lowNoteID = 21; // A0
        public readonly int highNoteID = 109; // C8

        public void initTools()
        {
            readNotesSequences();
            setScaleSequences();
        }
        public NoteTools(string configDir)
        {
            configDirectory = configDir;
            basicNotesFile = configDir + "\\basicPitches.txt";
            majorScaleSeqFile = configDir + "\\majorSequence.txt";
            minorScaleSeqFile = configDir + "\\minorSequence.txt";
            majorChordsFile = configDir + "\\majorChords.txt";
            minorChordsFile = configDir + "\\minorChords.txt";
        }

        #region Old
        public NoteTools(){
        }

        public List<Note> setNotesDuration(List<Note> notesList)
        {
            for (int i=0; i<notesList.Count-1; i++){
                notesList[i].endTime = notesList[i + 1].startTime;
                notesList[i].duration = notesList[i].endTime - notesList[i].startTime;
            }
            notesList[notesList.Count - 1].duration = AVGNoteDuration(notesList);
            notesList[notesList.Count - 1].endTime = notesList[notesList.Count - 1].startTime + notesList[notesList.Count - 1].duration;
            return notesList;
        }

        public int AVGNoteDuration(List<Note> allNotes)
        {
            int avgDuration = 0;
            for (int i = 1; i < allNotes.Count - 1; i++)
            {
                avgDuration += allNotes[i].duration;
            }
            return avgDuration / allNotes.Count - 2;
        }

        public int getNotesDiff(Note a, Note b){
            int diff = getBasicNotesDiff(a, b);
            diff = Math.Min(diff, 12 - diff);
            int octaves = Math.Abs(getNoteOctave(a) - getNoteOctave(b));
            return diff + (octaves *12);
        }

        public int getBasicNotesDiff(Note a, Note b)
        {
            int diff = 0;
            return diff;
        }

#endregion

        public int getNoteOctave(Note note)
        {
            return Convert.ToInt32(note.note[note.note.Length - 1]) - 48;
        }

        private void readNotesSequences()
        {
            Array lines = IOTools.ReadFrom(basicNotesFile).ToArray<String>();
            basicNotesSequence = new Dictionary<int, string>();
            foreach (String line in lines)
            {
                basicNotesSequence[Int32.Parse(line.Split(' ')[0].Trim())] = line.Split(' ')[1].Trim();
            }
        }

        private void setScaleSequences()
        {
            Array lines = IOTools.ReadFrom(majorScaleSeqFile).ToArray<String>();
            majorScaleSeq = new List<int>();
            foreach (String line in lines)
            {
                majorScaleSeq.Add(Int32.Parse(line.Trim()));
            }
            lines = IOTools.ReadFrom(minorScaleSeqFile).ToArray<String>();
            minorScaleSeq = new List<int>();
            foreach (String line in lines)
            {
                minorScaleSeq.Add(Int32.Parse(line.Trim()));
            }
        }
    }
}

