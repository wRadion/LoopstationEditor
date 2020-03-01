using System;
using System.Xml.Serialization;

using Loopstation.Xml.Memory;

namespace Loopstation.Xml.Base
{
    public abstract class XmlMemorySettingsBase : ICloneable
    {
        #region Tracks
        [XmlElement("TRACK1")]
        public XmlTrackSettings Track1;
        [XmlElement("TRACK2")]
        public XmlTrackSettings Track2;
        [XmlElement("TRACK3")]
        public XmlTrackSettings Track3;
        [XmlElement("TRACK4")]
        public XmlTrackSettings Track4;
        [XmlElement("TRACK5")]
        public XmlTrackSettings Track5;
        #endregion Tracks

        [XmlElement("RHYTHM")]
        public XmlRhythmSettings Rhythm;

        [XmlElement("NAME")]
        public XmlNameSettings Name;

        [XmlElement("MASTER")]
        public XmlMasterSettings Master;

        [XmlElement("REC_OPTION")]
        public XmlRecOptionSettings RecOption;

        [XmlElement("PLAY_OPTION")]
        public XmlPlayOptionSettings PlayOption;

        #region Assigns
        [XmlElement("ASSIGN1")]
        public XmlAssignSettings Assign1;
        [XmlElement("ASSIGN2")]
        public XmlAssignSettings Assign2;
        [XmlElement("ASSIGN3")]
        public XmlAssignSettings Assign3;
        [XmlElement("ASSIGN4")]
        public XmlAssignSettings Assign4;
        [XmlElement("ASSIGN5")]
        public XmlAssignSettings Assign5;
        [XmlElement("ASSIGN6")]
        public XmlAssignSettings Assign6;
        [XmlElement("ASSIGN7")]
        public XmlAssignSettings Assign7;
        [XmlElement("ASSIGN8")]
        public XmlAssignSettings Assign8;
        [XmlElement("ASSIGN9")]
        public XmlAssignSettings Assign9;
        [XmlElement("ASSIGN10")]
        public XmlAssignSettings Assign10;
        [XmlElement("ASSIGN11")]
        public XmlAssignSettings Assign11;
        [XmlElement("ASSIGN12")]
        public XmlAssignSettings Assign12;
        [XmlElement("ASSIGN13")]
        public XmlAssignSettings Assign13;
        [XmlElement("ASSIGN14")]
        public XmlAssignSettings Assign14;
        [XmlElement("ASSIGN15")]
        public XmlAssignSettings Assign15;
        [XmlElement("ASSIGN16")]
        public XmlAssignSettings Assign16;
        #endregion Assigns

        [XmlElement("INPUT_FX")]
        public XmlInputFxSettings InputFx;

        [XmlElement("TRACK_FX")]
        public XmlTrackFxSettings TrackFx;

        #region BeatFxs
        [XmlElement("BEAT_FX1")]
        public XmlBeatFxSettings BeatFx1;
        [XmlElement("BEAT_FX2")]
        public XmlBeatFxSettings BeatFx2;
        [XmlElement("BEAT_FX3")]
        public XmlBeatFxSettings BeatFx3;
        #endregion

        #region InputFxs
        [XmlElement("INPUT_FX1")]
        public XmlFxSettings InputFx1;
        [XmlElement("INPUT_FX2")]
        public XmlFxSettings InputFx2;
        [XmlElement("INPUT_FX3")]
        public XmlFxSettings InputFx3;
        #endregion InputFxs

        #region TrackFxs
        [XmlElement("TRACK_FX1")]
        public XmlFxSettings TrackFx1;
        [XmlElement("TRACK_FX2")]
        public XmlFxSettings TrackFx2;
        [XmlElement("TRACK_FX3")]
        public XmlFxSettings TrackFx3;
        #endregion TrackFxs

        public XmlMemorySettingsBase() : this(null) { }
        public XmlMemorySettingsBase(XmlMemorySettingsBase other)
        {
            #region Tracks
            Track1 = new XmlTrackSettings(other?.Track1);
            Track2 = new XmlTrackSettings(other?.Track2);
            Track3 = new XmlTrackSettings(other?.Track3);
            Track4 = new XmlTrackSettings(other?.Track4);
            Track5 = new XmlTrackSettings(other?.Track5);
            #endregion Tracks

            Rhythm = new XmlRhythmSettings(other?.Rhythm);
            Name = new XmlNameSettings(other?.Name);
            Master = new XmlMasterSettings(other?.Master);
            RecOption = new XmlRecOptionSettings(other?.RecOption);
            PlayOption = new XmlPlayOptionSettings(other?.PlayOption);

            #region Assigns
            Assign1 = new XmlAssignSettings(other?.Assign1);
            Assign2 = new XmlAssignSettings(other?.Assign2);
            Assign3 = new XmlAssignSettings(other?.Assign3);
            Assign4 = new XmlAssignSettings(other?.Assign4);
            Assign5 = new XmlAssignSettings(other?.Assign5);
            Assign6 = new XmlAssignSettings(other?.Assign6);
            Assign7 = new XmlAssignSettings(other?.Assign7);
            Assign8 = new XmlAssignSettings(other?.Assign8);
            Assign9 = new XmlAssignSettings(other?.Assign9);
            Assign10 = new XmlAssignSettings(other?.Assign10);
            Assign11 = new XmlAssignSettings(other?.Assign11);
            Assign12 = new XmlAssignSettings(other?.Assign12);
            Assign13 = new XmlAssignSettings(other?.Assign13);
            Assign14 = new XmlAssignSettings(other?.Assign14);
            Assign15 = new XmlAssignSettings(other?.Assign15);
            Assign16 = new XmlAssignSettings(other?.Assign16);
            #endregion

            InputFx = new XmlInputFxSettings(other?.InputFx);
            TrackFx = new XmlTrackFxSettings(other?.TrackFx);

            #region BeatFxs
            BeatFx1 = new XmlBeatFxSettings(other?.BeatFx1);
            BeatFx2 = new XmlBeatFxSettings(other?.BeatFx2);
            BeatFx3 = new XmlBeatFxSettings(other?.BeatFx3);
            #endregion BeatFxs

            #region InputFxs
            InputFx1 = new XmlFxSettings(other?.InputFx1);
            InputFx2 = new XmlFxSettings(other?.InputFx2);
            InputFx3 = new XmlFxSettings(other?.InputFx3);
            #endregion InputFxs

            #region TrackFxs
            TrackFx1 = new XmlFxSettings(other?.TrackFx1);
            TrackFx2 = new XmlFxSettings(other?.TrackFx2);
            TrackFx3 = new XmlFxSettings(other?.TrackFx3);
            #endregion TrackFxs
        }

        public abstract object Clone();
    }
}
