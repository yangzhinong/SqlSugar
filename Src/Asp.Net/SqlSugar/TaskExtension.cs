using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlSugar
{
    public static class TaskExtension
    {
        public  static Task<TResult> FromResult<TResult>(  TResult result)
        {
            
            TaskCompletionSource<TResult> tcs = new TaskCompletionSource<TResult>();
            Task<TResult> t1 = tcs.Task;
            tcs.SetResult(result);
            return t1;
        }
    }
}
