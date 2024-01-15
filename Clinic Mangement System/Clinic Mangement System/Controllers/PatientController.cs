using Clinic.BLL.Interfaces;
using Clinic.BLL.Reposatory;
using Clinic.DAL.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Clinic_Mangement_System.Controllers
{
    public class PatientController : Controller
    {
        private readonly IPatientRepository _patientRepository;
        private readonly IDoctorRepository _doctorRepository;
        private readonly ISpecalizationRepository _specialization;
        private readonly IAppointmentRepository _appointment;

        public PatientController(IPatientRepository patientRepo, IDoctorRepository doctorRepo, ISpecalizationRepository specalizationRepo, IAppointmentRepository appointmentRepo)
        {
            _patientRepository = patientRepo;
            _doctorRepository = doctorRepo;
            _specialization = specalizationRepo;
            _appointment = appointmentRepo;
        }
        public IActionResult Index()
        {
            var patient = _patientRepository.GetAll();
            return View(patient);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Patient p)
        {
            if (ModelState.IsValid)
            {
                _patientRepository.Create(p);
                return RedirectToAction("Index");
            }
            return View(p);
        }
        [HttpGet]
        public IActionResult CreateAppoin(int id)
        {
            List<Spatialization> spec = _specialization.GetAll().ToList();
            ViewBag.specList = new SelectList(spec, "SpatializationID", "Name");


            var patientName = _patientRepository.GetpatientName(id);
            ViewBag.patientName = patientName;
            ViewBag.patientID = id;

            return View();
        }
        [HttpPost]
        public IActionResult CreateAppoin(Appointment appo)
        {
            if (ModelState.IsValid)
            {
                _appointment.Create(appo);
                return RedirectToAction("Index");
            }
            return View(appo);
        }
        public IActionResult GetDocInSpec(int id)
        {
            var doctors = _doctorRepository.GetDoctorsBySpecialization(id);
            return Json(doctors);
        }


        public IActionResult Update(int id)
        {
            var appo = _appointment.Get(id);

            return View(appo);
        }

        [HttpPost]
        public IActionResult Update(Appointment appo)
        {
            if (ModelState.IsValid)
            {
                _appointment.Update(appo);
                return RedirectToAction("Index");
            }
            return View(appo);
        }

        public IActionResult Delete(int id)
        {
            var appo = _appointment.Get(id);
            return View(appo);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            var appo = _appointment.Get(id);
            _appointment.Delete(appo);
            return RedirectToAction("Index");
        }

            public IActionResult ViewAppointments(int id)
            {
                List<Appointment> apooi = _patientRepository.GetAllAppointment(id);
                ViewBag.PatientName = _patientRepository.Get(id).Name;
                return View(apooi);

            }
        }
    }

