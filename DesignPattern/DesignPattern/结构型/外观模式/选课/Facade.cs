using System;

namespace DesignPattern.结构型.外观模式.选课
{
    /// <summary>
    ///     外观类 处理对象交互
    /// </summary>
    public class Facade
    {
        private readonly NotifyStudent notifyStu;
        private readonly RegisterCourse registerCourse;

        public Facade()
        {
            registerCourse = new RegisterCourse();
            notifyStu = new NotifyStudent();
        }

        public bool RegisterCourse(string courseName, string studentName)
        {
            if (!registerCourse.CheckAvailable(courseName)) return false;

            return notifyStu.Notify(studentName);
        }
    }

    #region 子系统

    // 相当于子系统A
    public class RegisterCourse
    {
        public bool CheckAvailable(string courseName)
        {
            Console.WriteLine("正在验证课程 {0}是否人数已满", courseName);
            return true;
        }
    }

    // 相当于子系统B
    public class NotifyStudent
    {
        public bool Notify(string studentName)
        {
            Console.WriteLine("正在向{0}发生通知", studentName);
            return true;
        }
    }

    #endregion
}