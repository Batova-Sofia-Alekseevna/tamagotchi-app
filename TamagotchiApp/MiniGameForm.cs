using TamagotchiApp.JapaneseCrossing;

namespace TamagotchiApp
{
    public partial class MiniGameForm : Form
    {
        private Game _game = new();  //объявл игру

        public MiniGameForm()
        {
            InitializeComponent();   //все компоненты формы
        }

        private void MiniGameForm_MouseMove(object sender, MouseEventArgs e)  //обрабатываем перемещ мышкой
        {
            var person = _game.FindPersonAt(e.X, e.Y);  //нашли персонажа

            Cursor = person is null ? Cursors.Arrow : Cursors.Hand;  //измение курсора, рука или мышка

            if (person is null)
            {
                toolTip1.Hide(this);  //скрываем тултип
                return;
            }

            toolTip1.Show(person.Name, this, new Point(e.X, e.Y));  //показываем персонажа и название(кто он)
        }

        private void MiniGameForm_MouseDown(object sender, MouseEventArgs e)   //клик мышкой
        {
            if (_game.IsAnimationRunning)  //если идет анимация, то клик не работают
            {
                return;
            }

            var person = _game.FindPersonAt(e.X, e.Y);  //находим персонажа
            if (person is null)
            {
                return;
            }

            try  //пишем ошибки
            {
                if (person.InBoat)
                {
                    _game.Disembark(person); //высадка из лодки
                    ShowVictoryMessageIfNeeded();  //сообщение о выигрыше
                }
                else
                {
                    _game.Embark(person);  //посадить в лодку
                }

                Invalidate();  //пририсовать форму - инвалидейт
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonToRight_Click(object sender, EventArgs e)   //начали движ вправо
        {
            StartBoatMove(SideKind.Right);                             //сторону куда движемся
        }

        private void ButtonToLeft_Click(object sender, EventArgs e)    //влево
        {
            StartBoatMove(SideKind.Left);                              //сторона куда движемся
        }

        private void Timer1_Tick(object sender, EventArgs e)    //таймер
        {
            try
            {
                _game.AnimationStep();  //запуск анимации
                timer1.Enabled = _game.IsAnimationRunning;   //будет работать пока анимация
                Invalidate();   //перерисавать форму
            }
            catch (InvalidOperationException ex)
            {
                timer1.Enabled = false;   //если что, то вылетает ошибка
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StartBoatMove(SideKind targetSide)   //начало движ лодки
        {
            try
            {
                AddMoveToHistory(targetSide);  //добавить в историю ходов
                _game.StartMove(targetSide);
                timer1.Enabled = true;         //вкл таймер
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowVictoryMessageIfNeeded()  //соо о выигрыше
        {
            if (!_game.IsSuccess)
            {
                return;
            }

            MessageBox.Show(
              $"Поздравляем с победой за {_game.MoveCount} ходов",
              "Победа",
              MessageBoxButtons.OK,
              MessageBoxIcon.Information);
        }

        private void ButtonHint_Click(object sender, EventArgs e)  //выводим подсказку
        {
            var form = new HintForm();
            form.Show();  //показать форму
        }

        private void ButtonRestart_Click(object sender, EventArgs e)  //перезапуск
        {
            timer1.Stop();
            _game = new Game();  //новый объект
            Invalidate();
        }

        private void AddMoveToHistory(SideKind targetSide)  //добавление в историю ходов
        {
            textBoxProcess.AppendText(_game.GetCurrentMoveDescription(targetSide) + Environment.NewLine); //новая строка + описание
        }

        private void ButtonRules_Click(object sender, EventArgs e)   //правила 
        {
            var form = new RulesForm();
            form.Show();
        }

        private void MiniGameForm_Paint(object sender, PaintEventArgs e)  //отрисовка формы
        {
            _game.Draw(e.Graphics);
        }
    }

}
