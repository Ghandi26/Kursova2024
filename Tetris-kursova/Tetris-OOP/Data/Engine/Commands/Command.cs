using GameTetris; // Импортируем необходимые пространства имен
using Tetris.Data.GUI;

namespace Engine.Commands
{
    /// <summary>Класс Команды объявляет метод для выполнения команд.</summary>
    public abstract class Command
    {
        protected readonly PlayField _playField; // Ссылка на игровое поле
        protected readonly Game _game; // Ссылка на игру

        // Конструктор, принимающий игровое поле
        protected Command(PlayField playField)
        {
            _playField = playField;
        }

        // Конструктор, принимающий игру
        protected Command(Game game)
        {
            _game = game;
        }

        // Абстрактный метод для выполнения команды, который должен быть реализован в подклассах
        public abstract void Execute();
    }

    /// <summary>Класс инициализатор команд, отправляет запрос на команду.</summary>
    public class Invoker
    {
        private Command _command; // Ссылка на команду

        /// <summary>Команда поступившая на выполнение.</summary>
        public Command Command
        {
            set => _command = value; // Устанавливает команду на выполнение
        }

        /// <summary>Запуск команды.</summary>
        public void Run()
        {
            _command?.Execute(); // Если команда не пустая, то выполняется
            _command = null; // После выполнения обнуляем команду
        }
    }

    #region Команды движения и пауза

    /// <summary>Команда перемещения фигуры влево.</summary>
    public class MoveLeft : Command
    {
        public MoveLeft(PlayField playField) : base(playField) { }

        public override void Execute()
        {
            _playField.MoveLeft(); // Выполняет перемещение фигуры влево
        }
    }

    /// <summary>Команда перемещения фигуры вправо.</summary>
    public class MoveRight : Command
    {
        public MoveRight(PlayField playField) : base(playField) { }

        public override void Execute()
        {
            _playField.MoveRight(); // Выполняет перемещение фигуры вправо
        }
    }

    /// <summary>Команда перемещения фигуры вниз.</summary>
    public class MoveDown : Command
    {
        public MoveDown(PlayField playField) : base(playField) { }

        public override void Execute()
        {
            _playField.MoveDown(); // Выполняет перемещение фигуры вниз
        }
    }

    /// <summary>Команда мгновенного сброса фигуры вниз.</summary>
    public class MoveDrop : Command
    {
        public MoveDrop(PlayField playField) : base(playField) { }

        public override void Execute()
        {
            _playField.Drop(); // Выполняет мгновенный сброс фигуры вниз
        }
    }

    /// <summary>Команда поворота фигуры.</summary>
    public class MoveRotate : Command
    {
        public MoveRotate(PlayField playField) : base(playField) { }

        public override void Execute()
        {
            _playField.RotateFigure(); // Выполняет поворот фигуры
        }
    }

    /// <summary>Команда паузы в игре.</summary>
    public class MovePause : Command
    {
        public MovePause(Game game) : base(game) { }

        public override void Execute()
        {
            // Меняем значение на противоположное
            _game.Paused = !_game.Paused;

            // Открываем форму с паузой
            MenuPauseForm menu = new MenuPauseForm();
            menu.ShowDialog(); // Показываем диалоговое окно паузы

            // После закрытия меню - игра продолжается
            _game.Paused = !_game.Paused;
        }
    }
    #endregion
}