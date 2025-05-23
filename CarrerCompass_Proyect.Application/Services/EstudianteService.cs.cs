﻿using CarrerCompass_Proyect.Domain.Entities;
using CarrerCompass_Proyect.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerCompass_Proyect.Application.Services
{
    public class EstudianteService
    {
        private readonly IEstudianteRepositorio _repositorio;

        public EstudianteService(IEstudianteRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public Estudiante ObtenerPorId(int id)
        {
            return _repositorio.ObtenerPorId(id);
        }

        public IEnumerable<Estudiante> ObtenerTodos()
        {
            return _repositorio.ObtenerTodos();
        }

        public Estudiante RegistrarEstudiante(string nombre, string correo, DateTime fechaNacimiento)
        {
            var existente = _repositorio.ObtenerPorCorreo(correo);
            if (existente != null)
                throw new Exception("Ya existe un estudiante registrado con ese correo.");

            var estudiante = new Estudiante(nombre, correo, fechaNacimiento);
            _repositorio.Guardar(estudiante);
            return estudiante;
        }

    }
}

