using System.Collections.Generic;

namespace KanbanBoardDemo.ViewModels
{
    public class BoardList
    {
        public List<Board> Boards = new List<Board>();

        public class Board
        {
            public int Id { get; set; }
            public string Title { get; set; }
        }
    }
}
