using System;

namespace App
{
  public class Program
  {
    // Allows CRUD access to a list
    // Single word names
    // Update/Delete via index/name
    // No duplicates
    // When listing start with 1
    // Names > 1, not only whitespace, single words (no spaces)
    // Store in title case, search case-insensitive.
    static void Main()
    {
      bool quit = false;
      string[] names = new string[10] { "Aaron", "Marshal", "Tina", "Shawna", "Justin", "Marcus", "Abby", "Jim", "Martin", "Fay"};

      Console.WriteLine("Type an action name or 'help' for more information. 'q' to quit.");
      do
      {
        Console.WriteLine();
        string action = Console.ReadLine();
        try
        {
          switch(action.Trim().ToLower())
          {
            case "list":
              List(names);
              break;

            case "insert":
              Insert(names);
              break;

            case "update":
              Update(names);
              break;

            case "delete":
              Delete(names);
              break;

            case "quit":
            case "q":
              quit = true;
              break;

            case "help":
            default:
              // I'm aware this creates a new array on each call and I should
              // avoid this. However, I'd say its a toy app and this looks cleaner
              // to me.
              Console.WriteLine(string.Join(Environment.NewLine, new string[] {
                "list   - Lists all of the names",
                "update - Updates a name",
                "delete - Deletes a name",
                "insert - Inserts a new name",
                "quit   - quits the program",
                "help   - displays this window",
              }));
            break;
          }
        }
        catch(Exception ex)
        {
          Console.WriteLine("Error: {0}\n", ex.Message);
        }
      } while(!quit);
    }

    static int Count(string[] names)
    {
      int count = 0;
      foreach(string name in names)
      {
        if(name == null) { break; }
        count++;
      }
      return count;
    }

    static bool ValidateName(string name)
    {
      if(string.IsNullOrWhiteSpace(name) || name.Length < 2)
      {
        Console.WriteLine("A name must be greater than 1 character.");
        return false;
      }

      if(name.Contains(" "))
      {
        Console.WriteLine("Names must be single words.");
        return false;
      }

       return true;
    }

    static bool IsDuplicateName(string[] names, string toAddName)
    {
      toAddName = toAddName.ToLower();
      foreach(string name in names)
      {
        if(name != null && name.ToLower() == toAddName)
        {
          Console.WriteLine("Given name is already on the list. Try again.");
          return true;
        }
      }
      return false;
    }

    static int IndexOfName(string[] names, string toFindName)
    {
      toFindName = toFindName.ToLower();
      for(int i=0; i < names.Length; i++)
      {
        string name = names[i];
        if(name == null) { break; }
        if(name.ToLower() == toFindName)
        {
          return i;
        }
      }
      return -1;
    }

    static int GetIndexOfRecordToModify(string action, string[] names)
    {
      int count = Count(names);
      string method = "";
      do
      {
        Console.Write(string.Format("How would you like to {0} the record (index/name)? ", action));
        string input = Console.ReadLine().Trim().ToLower();

        if(input != "index" && input != "name")
        {
          Console.WriteLine("Unknown method selected. Valid options are 'index' or 'name'.");
        }
        else
        {
          method = input;
        }
      } while(string.IsNullOrEmpty(method));

      if(method == "index")
      {
        int index;
        do
        {
          Console.WriteLine("What index? ");
          index = int.Parse(Console.ReadLine().Trim());

          if(index < 0 || index >= count)
          {
            Console.WriteLine("Index out of range, try again.");
          }
        } while(index < 0 || index >= count);
        return index;
      }

      if(method == "name")
      {
        int index;
        do
        {
          Console.WriteLine("What Name? ");
          string nameToFind = Console.ReadLine().Trim().ToLower();
          index = IndexOfName(names, nameToFind);

          if(index < 0 || index >= count)
          {
            Console.WriteLine("Name not found, try again.");
          }
        } while(index < 0 || index >= count);

        return index;
      }

      return -1;
    }

    static void Update(string[] names)
    {
      string name;
      bool validName;
      bool isDuplicate;
      int updateIndex = GetIndexOfRecordToModify("update", names);
      string oldName = names[updateIndex];

      if(updateIndex == -1) { return; } // User didn't select a record to update.

      do
      {
        Console.Write(string.Format("Replace {0} with what name? ", oldName));
        name = Console.ReadLine().Trim();
        name = name[0].ToString().ToUpper() + name.ToLower().Substring(1);
        validName = ValidateName(name);
        isDuplicate = IsDuplicateName(names, name);
      } while(!validName && !isDuplicate);

      names[updateIndex] = name;
    }

    static void Delete(string[] names)
    {
      int updateIndex = GetIndexOfRecordToModify("delete", names);

      if(updateIndex == -1) { return; } // User didn't select a record to update.

      // Delete the name
      names[updateIndex] = null;

      // Compress the names array to move the null to the end
      for(int i=0; i < names.Length; i++)
      {
        string name = names[i];
        if(name != null) { continue; }

        for(int x=i+1; x < names.Length; x++)
        {
          //
          string forwardName = names[x];
          if(forwardName == null) { continue; }
          name = forwardName;
          names[x] = null;
          break;
        }

        if(name == null) { break; } //no more names
        names[i] = name;
      }
    }

    static void List(string[] names)
    {
      if(names[0] == null)
      {
        Console.WriteLine("No names recored.");
        return;
      }

      Console.WriteLine("List of names:");
      int count = 1;
      foreach(string name in names)
      {
        if(name == null) { break; } // At the end of the list
        Console.WriteLine(string.Format("{0}. {1}", count, name));
        count++;
      }
    }

    // Citation
    // https://stackoverflow.com/questions/4135317/make-first-letter-of-a-string-upper-case-with-maximum-performance
    // Used this to uppercase the first character in a string. Couldn't remember if .net had a method in the standard
    // library, guess not.
    static void Insert(string[] names)
    {
      int length = Count(names);

      if(length >= 10)
      {
        Console.WriteLine("Cannot add more than 10 names. Try updating some.");
        return;
      }

      string name;
      bool validName;
      bool isDuplicate;
      do
      {
        Console.Write("Enter a name: ");
        name = Console.ReadLine().Trim();
        name = name[0].ToString().ToUpper() + name.ToLower().Substring(1);
        validName = ValidateName(name);
        isDuplicate = IsDuplicateName(names, name);
      } while(!validName && !isDuplicate);

      names[length] = name;
    }
  }
}
