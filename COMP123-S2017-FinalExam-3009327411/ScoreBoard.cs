using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/*name:mehul khosla
 * studentId:300932741
 * date:august 17,2017
 * description:created class ScoreBoard
 * version:1.0
 */
namespace COMP123_S2017_FinalExam_3009327411
{
    public class ScoreBoard
    {
        //private instance variable
        private TextBox _finalScoreTextBox;
        private int _score;
        private TextBox _scoreTextBox;
        private int _time;
        private TextBox _timeTextBox;

        //public properties
        public TextBox FinalScoreTextBox
        {
            get { return this._finalScoreTextBox; }
            set
            {
                this._finalScoreTextBox = value;
                this.Score = Convert.ToInt32(this.FinalScoreTextBox.Text);
            }
        }
        public int Score
        {
            get
            {
                return this._score;
            }
            set
            {
                this._score = value;
                this.ScoreTextBox.Text = this._score.ToString();
            }
        }
        public TextBox ScoreTextBox
        {
            get
            {
                return this._scoreTextBox;
            }
            set
            {
                this._scoreTextBox = value;
            }
        }
        public int Time
        {
            get
            {
                return this._time;
            }
            set
            {
                this._time = value;
                this.TimeTextBox.Text = this.Time.ToString();
            }
        }
        public TextBox TimeTextBox
        {
            get
            {
                return this._timeTextBox;
            }
            set
            {
                this._timeTextBox = value;
            }
        }

        //constructors
        public ScoreBoard(TextBox scoreTextBox, TextBox timeTextBox, TextBox finalScoreTextBox)
        {
            this.ScoreTextBox = scoreTextBox;
            this.TimeTextBox = timeTextBox;
            this.FinalScoreTextBox = finalScoreTextBox;
        }


        //private methods


        //public methods
        public void UpdateTime()
        {
            int realTime = Convert.ToInt32(this.TimeTextBox.Text);
            realTime--;
            this.Time = realTime;
        }

    }
}
