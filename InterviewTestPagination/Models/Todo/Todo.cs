using System;

namespace InterviewTestPagination.Models.Todo {
    public class Todo {
        public long Id { get; set; }
        public string Task { get; set; }
        public DateTime CreatedDate { get; set; }

        public Todo(long id, string task, DateTime createdDate) {
            Id = id;
            Task = task;
            CreatedDate = createdDate;
        }
    }
}
