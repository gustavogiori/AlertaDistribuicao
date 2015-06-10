using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alerta_distribuição.Monitoramento
{
   public  class clsMonitoramento
    {

       string email="";
       int quantidade = 0;
       private FileSystemWatcher _watcher;
       
       public clsMonitoramento()
       {
           _watcher = new FileSystemWatcher();
          // _watcher.SynchronizingObject =  this;

           _watcher.Changed += new FileSystemEventHandler(LogFileSystemChanges);
           _watcher.Created += new FileSystemEventHandler(LogFileSystemChanges);
           _watcher.Deleted += new FileSystemEventHandler(LogFileSystemChanges);
           _watcher.Renamed += new RenamedEventHandler(LogFileSystemRenaming);
           _watcher.Error += new ErrorEventHandler(LogBufferError);


        
       }

       void LogBufferError(object sender, ErrorEventArgs e)
       {

       }



       /// <summary>
       /// Process renaming actions.
       /// </summary>
       void LogFileSystemRenaming(object sender, RenamedEventArgs e)
       {

       }



       /// <summary>
       /// Process creations, modifications and deletions.
       /// </summary>
       void LogFileSystemChanges(object sender, FileSystemEventArgs e)
       {
           string caminhoBanco = Configuração.clsConfiguracao.caminho;
           if (caminhoBanco == e.FullPath && e.ChangeType.ToString() == "Changed")
           {
               Emails.clsEmailsAutomaticos enviar = new Emails.clsEmailsAutomaticos();
               enviar.enviarEmail(quantidade, email,"");
             
           }
       }
 
   }

}
