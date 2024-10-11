using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vnr_InsternShip_Assignment.Models;
using Vnr_InsternShip_Assignment.UnitWork;

namespace Vnr_InsternShip_Assignment.Controllers
{
    public class KhoaHocsController : Controller
    {
        private readonly IUnitWork _unitwork;
        private readonly IMapper _mapper;

        public KhoaHocsController(IUnitWork unitwork, IMapper mapper)
        {
            _unitwork = unitwork;
            _mapper = mapper;
        }


        public async Task<IActionResult> Details(int? id)
        {
            try
            {
                if (id != null)
                {
                    var _listMonHocById = await _unitwork.KhoaHocRepository.GetListMonHocByKhoaHocId(id);
                    var _getKhoaHocById = await _unitwork.KhoaHocRepository.GetByIdAsync(id);
                    if(_getKhoaHocById != null)
                    {
                        string _nameKhoaHoc = _getKhoaHocById.TenKhoaHoc?? "";
                        ViewData["NameKhoaHoc"] = _nameKhoaHoc;
                        var _listMonHocByIdDTO = _mapper.Map<IEnumerable<MonHocDTO>>(_listMonHocById);
                        return View(_listMonHocByIdDTO);
                    }    
                }
                return NotFound();

            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }       
                   
        }
    }
}
