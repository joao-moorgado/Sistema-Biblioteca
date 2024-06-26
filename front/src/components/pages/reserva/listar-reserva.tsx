import React, { useEffect, useState } from "react";
import { Reserva } from "../../../models/Reserva";
import axios from "axios";
import { Link } from "react-router-dom";

function ListarReserva() {
  const [reservas, setReservas] = useState<Reserva[]>([]);

  useEffect(() => {
    carregarReservas();
  }, []);

  function carregarReservas() {
    fetch("http://localhost:5296/api/reserva/listar")
      .then((resposta) => resposta.json())
      .then((reservas: Reserva[]) => {
        setReservas(reservas);
      });
  }

  function deletar(id: string) {
    axios
      .delete(`/api/reserva/deletar/${id}`)
      .then((resposta) => {
        console.log(resposta.data);
        // Atualiza a lista de reservas após deletar
        setReservas(reservas.filter((reserva) => reserva.id !== id));
      })
      .catch((error) => console.error("Erro ao deletar reserva:", error));
  }

  return (
    <div className="container mt-4">
      <h1>Biblioteca de Reservas</h1>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>Livro</th>
            <th>Usuário</th>
            <th>Data Reserva</th>
            <th>Alterar</th>
            <th>Deletar</th>
          </tr>
        </thead>
        <tbody>
          {reservas.map((reserva) => (
            <tr key={reserva.id}>
              <td>{reserva.livroId}</td>
              <td>{reserva.usuarioId}</td>
              <td>{reserva.dataReserva}</td>
              <td>
                <Link to={`/pages/reserva/alterar/${reserva.id}`}>
                  Alterar
                </Link>
              </td>
              <td>
                <button
                  className="btn btn-danger"
                  onClick={() => deletar(reserva.id!)}
                >
                  Deletar
                </button>
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default ListarReserva;
