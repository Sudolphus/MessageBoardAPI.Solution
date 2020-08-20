using System;
using System.Collections.Generic;

namespace MessageBoardClient.Models
{
  public class Thread
  {
    public int ThreadId { get; set; }
    public string Title { get; set; }
    public DateTime CreationDate { get; set; }
    public int ParentBoardId { get; set; }
    public Board ParentBoard { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public ICollection<Post> Posts { get; set; }

    public Thread()
    {
      this.Posts = new HashSet<Post>();
    }

    public static List<Thread> GetAll()
    {
      ApiHelper apicallTask = ApiHelper.GetAll("threads");
      var result = apicallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Thread> threadList = JsonConvert.DeserializeObject<Thread>(jsonResponse.ToString());

      return threadList;
    }

    public static Post GetDetails(int id)
    {
      ApiHelper apiCallTask = ApiHelper.Get("posts", id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Thread thread = JsonConvert.DeserializeObject<Thread>(jsonResponse.ToString());

      return thread;
    }

    public static void Post(Thread thread)
    {
      string jsonBoard = JsonConvert.SerializeObject(thread);
      var apiCallTask = ApiHelper.Post("threads", jsonBoard);
    }

    public static void Put(Thread thread)
    {
      string jsonThread = JsonConvert.SerializeObject(thread);
      var apiCallTask = ApiHelper.Put("threads", thread.ThreadId, jsonThread);
    }

    public static void Delete(int id)
    {
      var apiCallTask = ApiHelper.Delete("threads", id);
    }
  }
}