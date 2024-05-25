import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class TaskService {
  private tasks: string[] = [];

  constructor() { }

  addTask(task: string) {
    this.tasks.push(task);
  }

  getTasks(): string[] {
    return this.tasks;
  }
}
