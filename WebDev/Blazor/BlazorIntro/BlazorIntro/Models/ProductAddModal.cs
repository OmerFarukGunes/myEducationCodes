using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorIntro.Models
{
    public class ProductAddModal
    {
        [Required]
        [StringLength(20,ErrorMessage = "Max 20 char")]
        public String ProductName { get; set; }
        //required yazarak productname  in gerekli olmasini saglayabilirsin.  hangi ozelligin uzerindeyse onu karsilar. birnevi modele kural koymaktir.
        [Required (ErrorMessage = "Need description of product")]
        [StringLength(40)]
        public string Description { get; set; }
        //olurda gorev yapilmadigi zaman erros messaage i degistirebilirsin.
        //stringlength ile maks girdiyi sinirlayabilirsin
      [Required]
        public string CategoryId { get; set; }
    }
}
