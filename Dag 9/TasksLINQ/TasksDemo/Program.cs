namespace TasksDemo
{
    internal class Program
    {
        static void MethodOne()
        {
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("---> M1\t" + i);
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            //Thread trd = new Thread(MethodOne);
            //trd.Start();

            // -------- ThreadPool ---------
            //ThreadPool.QueueUserWorkItem(
            //    (x) =>
            //    {
            //        Console.WriteLine("Work item x i running through the ThreadPool");
            //        for(int i = 0;i < 11; i++)
            //        {
            //            Console.WriteLine(i);
            //            Thread.Sleep(1000);
            //        }
            //    }
            //    ); // Task / work item will run in background
            //Console.WriteLine("Main thread finished");

            //Console.ReadKey();

            // -------------------- Tasks --------------------
            // --------- 3 ways to define tasks --------------

            // ----- 1 -----
            //Task t1 = new Task(MethodOne); // defining a task this way, task requires start()
            //t1.Start();
            //t1.Wait(); // Thread: Join(), Task: Wait()

            // ------ 2 -------
            //Task t2 = Task.Factory.StartNew(MethodOne); // Task starts automatically
            //t2.Wait();

            // ----- 3 -----
            // Task t3 = Task.Run(MethodOne);
            // Task t3 = Task.Run(new Action(MethodOne));

            // ----- Task with return type -----
            //Task<int> t4 = Task.Run(() => { return 9; });
            //Console.WriteLine("t4 result -> " + t4.Result);

            // ----- Continue With -----
            //Task<string> news = Task.Run(
            //    () => { return "Here are the news for today: "; }
            //    ).ContinueWith(
            //    (moreNews) => { return moreNews.Result + "\nMand faldet af stol"; }
            //    ).ContinueWith(
            //    (blabla) => { return blabla.Result + "\nKvinde købt stort brød ved bageren"; });

            //Console.WriteLine(news.Result);

            // ------ Wait() -- WaitAny() -- WaitAll() -----
            //Task[] tasks = new Task[3];
            //tasks[0] = Task.Run(() =>
            //{
            //    Thread.Sleep(7000);
            //    Console.WriteLine("Task[0] finished in 7 seconds");
            //});
            //tasks[1] = Task.Run(() =>
            //{
            //    Thread.Sleep(5000);
            //    Console.WriteLine("Task[1] finished in 5 seconds");
            //});
            //tasks[2] = Task.Run(() =>
            //{
            //    Thread.Sleep(3000);
            //    Console.WriteLine("Task[2] finished in 3 seconds");
            //});
            
            ////Task.WaitAny(tasks);
            //Task.WaitAll(tasks);

            List<Task<string>> taskList = new List<Task<string>>();
            taskList.Add(Task.Run(() => { Thread.Sleep(3000); return "Cat"; }));
            taskList.Add(Task.Run(() => { Thread.Sleep(5000); return "Armadillo"; }));
            taskList.Add(Task.Run(() => { Thread.Sleep(9000); return "Bat"; }));
            taskList.Add(Task.Run(() => { Thread.Sleep(7000); return "Sloth"; }));
            taskList.Add(Task.Run(() => { Thread.Sleep(6000); return "Hedgehog"; }));
            taskList.Add(Task.Run(() => { Thread.Sleep(9999); return "Sofus"; }));
            while (taskList.Count > 0)
            {
                // WaitAny returns an int - and is most commonly used with arrays
                int index = Task.WaitAny(taskList.ToArray());
                Task<string> completedTask = taskList[index];
                taskList.RemoveAt(index);
                Console.WriteLine($"\n{completedTask.Result} is finally waking up!");
            }


            Console.WriteLine("Main tråd her");
            Console.ReadKey();
        }
    }
}